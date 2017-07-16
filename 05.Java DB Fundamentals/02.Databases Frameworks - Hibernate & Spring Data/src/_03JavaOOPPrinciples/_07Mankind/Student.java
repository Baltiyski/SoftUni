package _03JavaOOPPrinciples._07Mankind;

/**
 * Created by StefanBaltiyski on 15.7.2017 г..
 */
public class Student extends Human{
    private String facNum;

    protected Student(String fname, String lname, String facNum) {
        super(fname, lname);
        this.setFacNum(facNum);
    }

    private String getFacNum() {
        return facNum;
    }

    private void setFacNum(String facNum) {
        if (facNum.length() < 5 || 10 < facNum.length()) {
            throw new IllegalArgumentException("Invalid faculty number!");
        }

        this.facNum = facNum;
    }

    @Override
    public String toString() {
        StringBuilder sb = new StringBuilder();
        sb.append("First Name: ").append(super.getFname())
                .append(System.lineSeparator())
                .append("Last Name: ").append(super.getLname())
                .append(System.lineSeparator())
                .append("Faculty number: ").append(getFacNum());

        return sb.toString();
    }
}
