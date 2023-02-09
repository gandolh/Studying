import java.util.ArrayList;
import java.util.List;
import java.util.stream.Collectors;

public class StreamsDemo {

    public static void main(String args[]){
        List<Integer> numberList = new ArrayList<>();
        numberList.add(10);
        numberList.add(20);
        numberList.add(30);
        numberList.add(40);
//        List<Integer> squareList = new ArrayList<>();
//        for(Integer i : numberList){
//            squareList.add(i*i);
//        }
//        List<Integer> squareList2 = numberList.stream().map(x-> x*x).collect(Collectors.toList());
//        System.out.println("squarelist with for: " + squareList);
//        System.out.println("squarelist with streams: " + squareList2);
//        Set<Integer> squareSet = new HashSet<>();
//        for(Integer i : numberList){
//            squareSet.add(i*i);
//        }
//        Set<Integer> squareSet2 = numberList.stream().map(x-> x*x).collect(Collectors.toSet());
//        System.out.println("squareset with for: " + squareList);
//        System.out.println("squareset with streams: " + squareList2);

        List<String> languages = new ArrayList<>();
        languages.add("Java");
        languages.add("Pyton");
        languages.add("Scala");
        languages.add("basic");
//        List<String> filterResult = new ArrayList<>();
//        for(String s : languages){
//            if(s.startsWith("P"))
//                filterResult.add(s);
//        }
//        List<String> filterResult2 = languages.stream().filter(s-> s.startsWith("P")).collect(Collectors.toList());
//
//        System.out.println("Programming languages that starts with p (with for): " + filterResult);
//        System.out.println("Programming languages that starts with p (with for): " + filterResult2);

        List<String> sortedList = languages.stream().sorted().collect(Collectors.toList());
        System.out.println("Languages sorted alphabetically: " + sortedList);
        System.out.println("printing all elements one by one ");
        languages.stream().forEach(y-> System.out.println("Element is: " + y));
        int sum = numberList.stream().reduce(0,(ans,i) -> ans+i);
        System.out.println("Sum of all elements in the numberList: " + sum);
    }
}
