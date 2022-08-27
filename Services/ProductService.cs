using System;
using System.Collections.Generic;
using AspNetCoreWebAPI.Models;

namespace AspNetCoreWebAPI.Services{
    public class ProductService{
        List<Product> _productList = null;
        public ProductService()
        {
            _productList = new List<Product>();

        }

        public List<Product> GetProducts(){
            
            return _productList;
        }

        public void AddProduct(Product product){
            _productList.Add(product);
        }
        public bool EditProduct(string OldName, string Name){
            for(int i=0; i<_productList.Count; i++){
                if(_productList[i].Name == OldName){
                    _productList[i].Name = Name;
                    return true;
                }
            }
            return false;
        }

        public bool DeleteProduct(string Name){
            foreach (Product product in _productList)
            {
                if(product.Name == Name){
                    product.Name = null;
                    product.Price = Convert.ToDouble(null);
                    return true;
                }   
            }
            return false;
        }
    }
}