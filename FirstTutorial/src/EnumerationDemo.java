public class EnumerationDemo {

    public static void main(String args[]){
        Color c1 = Color.RED;
        System.out.println("Red enum name: " + c1.name());
        System.out.println("Red enum value: " + c1.getValue());
        for(Color color : Color.values()){
            System.out.println(" enum value: " + color.getValue());
            System.out.println(" enum name: " + color.name());
        }
    }
}
