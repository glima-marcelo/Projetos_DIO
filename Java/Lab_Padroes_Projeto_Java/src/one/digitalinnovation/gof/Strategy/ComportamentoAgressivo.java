package one.digitalinnovation.gof.Strategy;

public class ComportamentoAgressivo implements IComportamento {

    @Override
    public void mover() {
        System.out.println("Movendo-se agressivamente...");
    }
}
