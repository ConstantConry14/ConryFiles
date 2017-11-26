import java.util.Scanner;


public class HomerSimsponsDounuts {

    
    public static void main(String[] args) {
        int eDounuts =20; 
        
        System.out.println("Welcome to Homer's Dounuts");
       
        Scanner input = new Scanner(System.in);
        
        
         System.out.println("How many Donuts will you today?: ");
         
            eDounuts = input.nextInt();
           
         if(eDounuts > 15){
         
            System.out.println("Sorry we do not have enough in that size");
         }else if(eDounuts < 8 ){
    
        System.out.println("Ok, we have that amount");
          }
         
         
         
      
        }
        
       
    }
    

