
package pizza;


abstract class ToppingDecorator extends Pizza {
    
    protected Pizza tempPizza; 
    
    public ToppingDecorator(Pizza newPizza){
    
        tempPizza = newPizza; 
    }
    public double getDescription(){
    
    return tempPizza.getDescription();
    }
    public double getCost(){
    
    return tempPizza.getCost();
    }
    
}
