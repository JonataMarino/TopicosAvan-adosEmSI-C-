SELECT atendimento.idAtendimento, atendimento.dataAtendimento, 
				atendimento.horaAtendimento, atendimento.profResponsavel, 
				 animal.idAnimal, animal.nomeAnimal, animal.idadeAnimal,
				animal.porteAnimal, animal.racaAnimal, baia.idBaia, baia.localBaia, 
				dono.idDono, dono.nomeDono, dono.endereco, dono.telefone,
				servico.idServico, servico.descricaoServico
			FROM tbl_atendimento as atendimento 
            JOIN tbl_donoAnimal as dono ON atendimento.idDono = dono.idDono 
            JOIN tbl_baia as baia ON atendimento.idBaia = baia.idBaia 
            JOIN tbl_animal as animal ON atendimento.idAnimal = animal.idAnimal 
			JOIN tbl_servico as servico ON atendimento.idServico = servico.idServico 
            WHERE idAtendimento = idAtendimento;