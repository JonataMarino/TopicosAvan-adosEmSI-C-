SELECT cliente.idcliente, cliente.nomeCliente, cliente.telefoneCliente, cliente.enderecoCliente,
cliente.dataCriado, conta.idConta, conta.tipoConta, conta.beneficioConta, conta.classeConta,
conta.contaLimite, conta.dataCriada FROM tbl_cliente cliente left join TBL_CONTA conta
on cliente.idcliente = conta.idcliente;