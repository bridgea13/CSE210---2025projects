using System.Numerics;

public class Product{
    private string _productName;
    private int _productID;
    private int _pricePerUnit;
    private int _quantitiy;
public Product(string productName, int productID,int pricePerUnit,int quantitiy){
    _productName = productName;
    _productID = productID;
    _pricePerUnit = pricePerUnit;
    _quantitiy = quantitiy;
}
    public int TotalCost (){
        return _pricePerUnit * _quantitiy;
    }
    public string PackingLabel(){
        string label = _productName + "," + _productID +"\n" ;
        return label ;
    }

}