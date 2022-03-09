package subsistema2.cep;

public class CepApi {

    private static CepApi instancia = new CepApi();

    private CepApi() {
        super();
    }

    public static CepApi getInstancia() {
        return instancia;
    }

    public String recuperarCidade() {
        return "Paraguaçu Paulista";
    }

    public String recuperarEstado() {
        return "SP";
    }
}
