
package company1;


public class employee {
    
    private String name; 
    private String address; 
    private int number; 
    public employee(String name, String address, int number){//setter
    
        System.out.println("Constructing employees");
        this.name = name;
        this.address = address; 
        this.number = number; 
        
    }
    public void checkMail(){// created method
    
        System.out.println("Please Check mail for: " + this.name + "  " + this.address);
    
    }
    public String toString(){
    
        return name + " " + address + " " + number; 
    
    }
    public String getName(){//getter
    
    return name;
    }
    public String getAddress(){//getter
    
    return address;
    }
    public int getNumber(){
    
        return number; 
    }
    
    
}
