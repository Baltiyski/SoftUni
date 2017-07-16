package _03JavaOOPPrinciples._07Mankind;

/**
 * Created by StefanBaltiyski on 15.7.2017 г..
 */
public abstract class Human {
    private String fname;
    private String lname;

    protected Human(String fname, String lname) {
        this.setFname(fname);
        this.setLname(lname);
    }

    protected String getFname() {
        return this.fname;
    }

    private void setFname(String fname) {
        if (fname.toUpperCase().charAt(0) != fname.charAt(0)) {
            throw new IllegalArgumentException("Expected upper case letter!Argument: " + fname);
        }
        if (fname.length() < 4) {
            throw new IllegalArgumentException("Expected length at least 4 symbols!Argument: " +fname);
        }
        this.fname = fname;
    }

    protected String getLname() {
        return lname;
    }

    private void setLname(String lname) {
        if (lname.toUpperCase().charAt(0) != lname.charAt(0)) {
            throw new IllegalArgumentException("Expected upper case letter!Argument: " + lname);
        }
        if (lname.length() < 3) {
            throw new IllegalArgumentException("Expected length at least 4 symbols!Argument: " +lname);
        }
        this.lname = lname;
    }
}
