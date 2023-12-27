namespace BLL;
using BOL;
using DAL;

public  class CatalogManager
{

    public   List<Product> GetAllProducts(){

        List<Product> plist=DBManager.GetAllProducts();
        return plist;
    } 

}
