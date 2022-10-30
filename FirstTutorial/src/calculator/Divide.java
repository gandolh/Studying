package calculator;

public class Divide implements Operate {
    @Override
    public Double getResult(Double... numbers) {
        Double division = numbers[0] * numbers[0];
        for( Double num : numbers){
            division/=num;
        }
        return division;
    }
}
