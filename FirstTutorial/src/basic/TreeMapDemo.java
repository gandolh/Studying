package basic;

import java.util.TreeMap;

public class TreeMapDemo {
    public static void main(String args[]){
        TreeMap<Integer,String> treemap = new TreeMap<Integer,String>();
        treemap.put(3,"A");
        treemap.put(2,"B");
        treemap.put(1,"C");
        System.out.println(treemap);
    }


}
