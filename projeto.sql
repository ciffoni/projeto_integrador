-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 15-Ago-2025 às 18:10
-- Versão do servidor: 10.4.32-MariaDB
-- versão do PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `projeto`
--
CREATE DATABASE IF NOT EXISTS `projeto` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `projeto`;

-- --------------------------------------------------------

--
-- Estrutura da tabela `cargo`
--

DROP TABLE IF EXISTS `cargo`;
CREATE TABLE `cargo` (
  `codigocargo` int(11) NOT NULL,
  `cargo` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `cargo`
--

INSERT INTO `cargo` (`codigocargo`, `cargo`) VALUES
(1, 'administração'),
(2, 'Vendedor');

-- --------------------------------------------------------

--
-- Estrutura da tabela `cliente`
--

DROP TABLE IF EXISTS `cliente`;
CREATE TABLE `cliente` (
  `codigocliente` int(11) NOT NULL,
  `nome` varchar(60) DEFAULT NULL,
  `fone` varchar(15) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `cnpj_cpf` varchar(30) DEFAULT NULL,
  `cep` varchar(20) DEFAULT NULL,
  `num_casa` varchar(4) DEFAULT NULL,
  `complemento` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estrutura da tabela `fluxocaixa`
--

DROP TABLE IF EXISTS `fluxocaixa`;
CREATE TABLE `fluxocaixa` (
  `codigofluxo` int(11) NOT NULL,
  `descricao` varchar(100) DEFAULT NULL,
  `tipo` varchar(50) DEFAULT NULL,
  `valor` decimal(5,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estrutura da tabela `pedido`
--

DROP TABLE IF EXISTS `pedido`;
CREATE TABLE `pedido` (
  `codigopedido` int(11) NOT NULL,
  `data_pedido` datetime DEFAULT NULL,
  `data_entrega` datetime DEFAULT NULL,
  `codigousuario` int(11) DEFAULT NULL,
  `codigocliente` int(11) DEFAULT NULL,
  `formapagamento` varchar(60) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estrutura da tabela `pedido_itens`
--

DROP TABLE IF EXISTS `pedido_itens`;
CREATE TABLE `pedido_itens` (
  `codigoitens` int(11) NOT NULL,
  `codigopedido` int(11) DEFAULT NULL,
  `codigoproduto` int(11) DEFAULT NULL,
  `quantidade` int(11) DEFAULT NULL,
  `valor` decimal(5,2) DEFAULT NULL,
  `total` decimal(5,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estrutura da tabela `produto`
--

DROP TABLE IF EXISTS `produto`;
CREATE TABLE `produto` (
  `codigoProduto` int(11) NOT NULL,
  `descricao` varchar(100) DEFAULT NULL,
  `valor` decimal(5,2) DEFAULT NULL,
  `quantidade` int(11) DEFAULT NULL,
  `foto` varchar(100) DEFAULT NULL,
  `nome` varchar(100) DEFAULT NULL,
  `tipo` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `produto`
--

INSERT INTO `produto` (`codigoProduto`, `descricao`, `valor`, `quantidade`, `foto`, `nome`, `tipo`) VALUES
(4, 'queijo,molho,calabresa', 18.00, 30, 'Produto\\calabresa.png', 'calabresa pizza', 6);

-- --------------------------------------------------------

--
-- Estrutura da tabela `tipo`
--

DROP TABLE IF EXISTS `tipo`;
CREATE TABLE `tipo` (
  `codigotipo` int(11) NOT NULL,
  `descricao` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `tipo`
--

INSERT INTO `tipo` (`codigotipo`, `descricao`) VALUES
(5, 'calzone'),
(6, 'pizza');

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuario`
--

DROP TABLE IF EXISTS `usuario`;
CREATE TABLE `usuario` (
  `codigo` int(11) NOT NULL,
  `nome` varchar(100) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `senha` varchar(255) DEFAULT NULL,
  `cargo` int(11) DEFAULT NULL,
  `ativo` tinyint(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Extraindo dados da tabela `usuario`
--

INSERT INTO `usuario` (`codigo`, `nome`, `email`, `senha`, `cargo`, `ativo`) VALUES
(1, 'jorge ciffoni', 'ciffoni@gmail.com', '$2b$10$b0mjbDwD6NJ2CXYNR6CN8e/VDdIGdmnoRvVDMr29OlTQD9tbEXxVm', 1, 1);

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `cargo`
--
ALTER TABLE `cargo`
  ADD PRIMARY KEY (`codigocargo`);

--
-- Índices para tabela `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`codigocliente`);

--
-- Índices para tabela `fluxocaixa`
--
ALTER TABLE `fluxocaixa`
  ADD PRIMARY KEY (`codigofluxo`);

--
-- Índices para tabela `pedido`
--
ALTER TABLE `pedido`
  ADD PRIMARY KEY (`codigopedido`),
  ADD KEY `fk_usuario` (`codigousuario`),
  ADD KEY `fk_cliente` (`codigocliente`);

--
-- Índices para tabela `pedido_itens`
--
ALTER TABLE `pedido_itens`
  ADD PRIMARY KEY (`codigoitens`),
  ADD KEY `fk_pedido` (`codigopedido`),
  ADD KEY `fk_produto` (`codigoproduto`);

--
-- Índices para tabela `produto`
--
ALTER TABLE `produto`
  ADD PRIMARY KEY (`codigoProduto`),
  ADD KEY `fk_tipo` (`tipo`);

--
-- Índices para tabela `tipo`
--
ALTER TABLE `tipo`
  ADD PRIMARY KEY (`codigotipo`);

--
-- Índices para tabela `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`codigo`),
  ADD KEY `fk_cargo` (`cargo`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `cargo`
--
ALTER TABLE `cargo`
  MODIFY `codigocargo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `cliente`
--
ALTER TABLE `cliente`
  MODIFY `codigocliente` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `fluxocaixa`
--
ALTER TABLE `fluxocaixa`
  MODIFY `codigofluxo` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `pedido`
--
ALTER TABLE `pedido`
  MODIFY `codigopedido` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `pedido_itens`
--
ALTER TABLE `pedido_itens`
  MODIFY `codigoitens` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `produto`
--
ALTER TABLE `produto`
  MODIFY `codigoProduto` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de tabela `tipo`
--
ALTER TABLE `tipo`
  MODIFY `codigotipo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de tabela `usuario`
--
ALTER TABLE `usuario`
  MODIFY `codigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `pedido`
--
ALTER TABLE `pedido`
  ADD CONSTRAINT `fk_cliente` FOREIGN KEY (`codigocliente`) REFERENCES `cliente` (`codigocliente`),
  ADD CONSTRAINT `fk_usuario` FOREIGN KEY (`codigousuario`) REFERENCES `usuario` (`codigo`);

--
-- Limitadores para a tabela `pedido_itens`
--
ALTER TABLE `pedido_itens`
  ADD CONSTRAINT `fk_pedido` FOREIGN KEY (`codigopedido`) REFERENCES `pedido` (`codigopedido`),
  ADD CONSTRAINT `fk_produto` FOREIGN KEY (`codigoproduto`) REFERENCES `produto` (`codigoProduto`);

--
-- Limitadores para a tabela `produto`
--
ALTER TABLE `produto`
  ADD CONSTRAINT `fk_tipo` FOREIGN KEY (`tipo`) REFERENCES `tipo` (`codigotipo`);

--
-- Limitadores para a tabela `usuario`
--
ALTER TABLE `usuario`
  ADD CONSTRAINT `fk_cargo` FOREIGN KEY (`cargo`) REFERENCES `cargo` (`codigocargo`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
