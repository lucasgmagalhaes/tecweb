CREATE TABLE `produtos` (
  `id` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `url` varchar(500) DEFAULT NULL,
  `nome` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
 
INSERT INTO `produtos` (`id`, `url`, `nome`)
VALUES
    (1, 'https://imgmanagercb-a.akamaihd.net/liquidificador/philips-walita-ri2134-2-4-litros_300x300-PU993f6_1.jpg', 'Liquidificador Oferta'),
    (2, 'https://a-static.mlcdn.com.br/618x463/fritadeira-eletrica-sem-oleo-air-fryer-britania-air-fry-bfr02pi-preta-e-cinza-32l-com-timer/magazineluiza/218979800/33240b5c3618f0b952be8f14884cb2d7.jpg', 'Fritadeira Elétrica Sem Óleo/Air Fryer'),
    (3, 'https://www.jaguarequipamentos.com/wp-content/uploads/2016/09/2-eixos-1.png', 'Triturador 2 Eixos '),
    (4, 'https://http2.mlstatic.com/coifa-vidro-curvo-parede-blackinox-75cm-5-bocas-terim-D_NQ_NP_881052-MLB27453010548_052018-F.jpg', 'Coifa Vidro Curvo Parede Black');