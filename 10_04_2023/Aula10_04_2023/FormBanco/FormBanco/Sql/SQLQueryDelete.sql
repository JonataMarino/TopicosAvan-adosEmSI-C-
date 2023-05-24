DELETE FROM TBL_CONTA WHERE idcliente IN (SELECT idcliente FROM tbl_cliente);

DELETE FROM tbl_cliente;
