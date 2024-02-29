public class Calculation {
    private ing a;
    private ing b;

    puplic Calculation(int a, int b){
        this.a = a;
        this.b = b;
    }
    puplic int sum() {
        return a + b;
    }

    puplic int minus() {
        return a - b;
    }
    puplic static void main(String[] args) {
        Calculation cal = new Calculation(a:5, b:7);
        System.out.println(cal.sum());
    }
}
