/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package company1;


public class salary extends employee {

    private double salary;
    public salary(String name, String address, int number, double salary) {
        super(name, address, number);
        setSalary(salary);
    }
    public void mailCheck(){
    
        System.out.println("Within the mailCheck of Salary");
        System.out.println("Mailing Checking to " + getName() + " With Salary"  + salary);
    
    }
    public double getSalary(){
    
    return salary; 
    }
    public void setSalary(double newSalary){
    
        if (newSalary > 0.0){
        
            salary = newSalary; 
        }
    }
    public double computerPay(){
    
        System.out.println("Computer salary pay for " + getName());
        return salary/52; //?
    }
}
