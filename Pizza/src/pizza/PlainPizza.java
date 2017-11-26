
package pizza;


public class PlainPizza extends Pizza{
    
    public String getDescription(){
    
        return "Thin Dough";
        
    }
    public double getCost(){
    
        System.out.println("Cost of Dough" + 4.00);
        return 4.00;
    }
    
}
