public class Cart{
    private List<Item> _shoppingCart;
    
    public void DisplayCart(){
        for (int i = 0; i< _shoppingCart.Count();i++){
            _shoppingCart[i].DisplayProduct();
        }

    }
    public List<Item> GetShoppingCart(){
        return _shoppingCart;
    }

}