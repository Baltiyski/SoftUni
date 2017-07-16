package _03JavaOOPPrinciples._06BirthdayCelabrations;

/**
 * Created by StefanBaltiyski on 15.7.2017 г..
 */
public abstract class DateOrID {
    private String idDate;

    protected DateOrID(String idDate) {
        this.idDate = idDate;
    }

    public String getIdDate(){
        return this.idDate;
    }

    public boolean isDate(String idDate) {
        return this.idDate.endsWith(idDate);
    }
}
