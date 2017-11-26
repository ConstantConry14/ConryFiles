
package pizza;


public class Mozzarella extends ToppingDecorator {

    public Mozzarella(Pizza newPizza) {
        super(newPizza);
        
        System.out.println("Adding Dough");
        
        System.out.println("Adding Mozz");
        
        
    }
    public String getDescription(){
    
        return tempPizza.getDescription()+ ", mozzarella";
    }
    public String getCost(){
    
        System.out.println("Cost of Mozza" + .50);
        return tempPizza.getCost()+ .50;
    }
    
}
