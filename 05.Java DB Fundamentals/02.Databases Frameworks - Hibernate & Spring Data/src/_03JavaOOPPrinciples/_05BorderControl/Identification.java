package _03JavaOOPPrinciples._05BorderControl;

/**
 * Created by StefanBaltiyski on 15.7.2017 г..
 */
public abstract class Identification {
    private String id;

    protected Identification(String id){
        this.id = id;
    }

    public String getId(){
        return id;
    }

    public boolean isFake(String id) {
        return this.id.endsWith(id);
    }
}
