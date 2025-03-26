using System.Numerics;

public class Product{
    private string _productName;
    private int _productID;
    private int _pricePerUnit;
    private int _quantity;
public Product(string productName, int productID,int pricePerUnit,int quantity){
    _productName = productName;
    _productID = productID;
    _pricePerUnit = pricePerUnit;
    _quantity = quantity;
}
    public int TotalCost (){
        return _pricePerUnit * _quantity;
    }
    public string PackingLabel(){
        string label = _productName + "," + _productID +"\n" ;
        return label ;
    }

}