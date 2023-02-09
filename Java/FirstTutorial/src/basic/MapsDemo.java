package basic;

import java.util.HashMap;
import java.util.Map;

public class MapsDemo {
    public static void main(String args[]) {
        Map<String, Integer> map = new HashMap();
        map.put("a", 10);
        map.put("b", 20);
        map.put("c", 30);
        System.out.println("Size of map is: " + map.size());
        System.out.println(map);
        if (map.containsKey("a")) {
            System.out.println("map contains a: " + map.get("a"));
        }
        System.out.println("The keys:");
        for (String key : map.keySet()) System.out.print("key: " + key + " ");
        System.out.println();
        for(Map.Entry<String, Integer> entry : map.entrySet())
            System.out.println("key: " + entry.getKey() + " value:" + entry.getValue());
    }
}
