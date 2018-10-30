package com.company;

import java.util.*;

public class Main {

    public static void main(String[] args) {
        DesignPattern pattern1 = new DesignPattern("Creational", "Factory Method");
        DesignPattern pattern2 = new DesignPattern("Creational", "Abstract Factory");
        DesignPattern pattern3 = new DesignPattern("Structural", "Adapter");
        DesignPattern pattern4 = new DesignPattern("Structural", "Bridge");
        DesignPattern pattern5 = new DesignPattern("Behavioral", "Chain of Responsibility");
        DesignPattern pattern6 = new DesignPattern("Behavioral", "Iterator");

        Set<DesignPattern> patternSet = new LinkedHashSet<>();
        patternSet.add(pattern1);
        patternSet.add(pattern2);
        patternSet.add(pattern3);
        patternSet.add(pattern4);
        patternSet.add(pattern5);
        patternSet.add(pattern6);

        Iterator iterador = patternSet.iterator();

        while (iterador.hasNext()) {
            System.out.println(iterador.next());
        }

    }
}
