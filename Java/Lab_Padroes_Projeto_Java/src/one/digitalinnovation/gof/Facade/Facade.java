package one.digitalinnovation.gof.Facade;

import subsistema1.crm.CrmService;
import subsistema2.cep.CepApi;

public class Facade {
    public void migrarCliente(String nome, String cep) {
        String cidade = CepApi.getInstancia().recuperarCidade();
        String estado = CepApi.getInstancia().recuperarEstado();

        CrmService.gravarCliente(nome, cep, cidade, estado);
    }
}
