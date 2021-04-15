-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1
-- Время создания: Апр 15 2021 г., 11:20
-- Версия сервера: 10.4.17-MariaDB
-- Версия PHP: 8.0.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `mto4`
--

-- --------------------------------------------------------

--
-- Структура таблицы `contract`
--

CREATE TABLE `contract` (
  `PK_Contract` int(11) NOT NULL,
  `ContractNumber` varchar(50) DEFAULT NULL,
  `ConclusionDate` date DEFAULT NULL,
  `StartDate` date DEFAULT NULL,
  `ExpiredDate` date DEFAULT NULL,
  `ConclusionCity` varchar(100) DEFAULT NULL,
  `ProviderAgentName` varchar(250) DEFAULT NULL,
  `ProviderAgentRole` varchar(100) DEFAULT NULL,
  `CustomerAgentName` varchar(250) DEFAULT NULL,
  `CustomerAgentRole` varchar(100) DEFAULT NULL,
  `SupplierPenalty` decimal(10,2) DEFAULT NULL,
  `CustomerPenalty` decimal(10,2) DEFAULT NULL,
  `PK_Provider` int(11) DEFAULT NULL,
  `PK_OrganizationDescription` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Дамп данных таблицы `contract`
--

INSERT INTO `contract` (`PK_Contract`, `ContractNumber`, `ConclusionDate`, `StartDate`, `ExpiredDate`, `ConclusionCity`, `ProviderAgentName`, `ProviderAgentRole`, `CustomerAgentName`, `CustomerAgentRole`, `SupplierPenalty`, `CustomerPenalty`, `PK_Provider`, `PK_OrganizationDescription`) VALUES
(1, '035386834068', '2021-03-04', '2021-09-04', '2021-09-07', 'Барнаул', 'Петров А.К.', 'Сторож', 'Степанов А.А.', 'Бухгатлер', '25.00', '1.00', 1, 1),
(2, '305990325594', '2021-03-04', '2021-01-01', '2021-06-04', 'Москва', NULL, '', '', '', '25.00', '1.00', 3, 1),
(3, '320116143306', '2021-02-02', '2021-01-01', '2021-03-02', 'Артем', NULL, '', '', '', '70.00', '1.00', 4, 1),
(7, '1221222222', '2021-04-08', '2021-04-08', '2021-04-09', 'Барнаул', 'Кутя', 'Студент', 'Максимка', 'Студент', '8.00', '13.00', 1, 1),
(9, '1111', '2021-04-01', '2021-04-01', '2021-04-08', 'г Барнаул', 'Борзенко М.А', 'Директор', 'Куторкин А.С', 'Директор', '0.00', '75.00', 1, 1);

-- --------------------------------------------------------

--
-- Структура таблицы `contractline`
--

CREATE TABLE `contractline` (
  `PK_ContractLine` int(11) NOT NULL,
  `PK_Resource` int(11) DEFAULT NULL,
  `Amount` float DEFAULT NULL,
  `UnitPrice` decimal(15,2) DEFAULT NULL,
  `DeliveryDate` date DEFAULT NULL,
  `PK_Contract` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Дамп данных таблицы `contractline`
--

INSERT INTO `contractline` (`PK_ContractLine`, `PK_Resource`, `Amount`, `UnitPrice`, `DeliveryDate`, `PK_Contract`) VALUES
(1, 5, 100, '30.00', '2021-04-09', 1),
(2, 4, 1000, '10.00', '2021-04-09', 1),
(3, 7, 5, '250000.00', '2021-04-06', 2),
(4, 8, 1, '313000.00', '2021-04-06', 2),
(5, 2, 1000, '500.00', '2021-03-02', 3),
(6, 1, 1200, '600.00', '2021-03-02', 3);

-- --------------------------------------------------------

--
-- Структура таблицы `organizationdescription`
--

CREATE TABLE `organizationdescription` (
  `PK_OrganizationDescription` int(11) NOT NULL,
  `Name` varchar(250) DEFAULT NULL,
  `DirectorName` varchar(250) DEFAULT NULL,
  `Address` varchar(255) DEFAULT NULL,
  `PhoneNumber` varchar(100) DEFAULT NULL,
  `INN` varchar(100) DEFAULT NULL,
  `CheckingAccount` varchar(100) DEFAULT NULL,
  `CorrespondentAccount` varchar(100) DEFAULT NULL,
  `BIK` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Дамп данных таблицы `organizationdescription`
--

INSERT INTO `organizationdescription` (`PK_OrganizationDescription`, `Name`, `DirectorName`, `Address`, `PhoneNumber`, `INN`, `CheckingAccount`, `CorrespondentAccount`, `BIK`) VALUES
(1, 'ООО \"Бригада пацанов\"', 'Артемов Максим Евгеньевич', '675960, г. Сальск, ул. Курчатова, 102, 86', '+7 (953) 243-71-71', '898843448054', '123', '456', '789');

-- --------------------------------------------------------

--
-- Структура таблицы `provider`
--

CREATE TABLE `provider` (
  `PK_Provider` int(11) NOT NULL,
  `Name` varchar(100) DEFAULT NULL,
  `INN` varchar(100) DEFAULT NULL,
  `Address` varchar(200) DEFAULT NULL,
  `PhoneNumber` varchar(30) DEFAULT NULL,
  `CheckingAccount` varchar(100) DEFAULT NULL,
  `CorrespondentAccount` varchar(100) DEFAULT NULL,
  `BIK` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Дамп данных таблицы `provider`
--

INSERT INTO `provider` (`PK_Provider`, `Name`, `INN`, `Address`, `PhoneNumber`, `CheckingAccount`, `CorrespondentAccount`, `BIK`) VALUES
(1, 'ООО \"Рога\"', '435742342508', '357875, г. Ермаковское, ул. Генерала Антонова, 185, 320', '+7 (989) 087-88-81', '123', '456', '789'),
(2, 'ООО \"Копытa\"', '566849331252', '143362, г. Кудымкар, ул. Локомотивная, 78, 560', '+7 (923) 180-02-01', '', '', ''),
(3, 'ООО \"Хвосты\"', '036038837214', '174520, г. Дворкино, ул. Рубинштейна,  55,  36', '+7 (936) 252-60-22', '', '', ''),
(4, 'ООО \"Подковы\"', '419443644463', '164288, г. Жирновск, ул. Бронный 16-й пер, 5, 152', '+7 (983) 208-87-98', '', '', ''),
(5, 'ООО \"Бригады\"', '084387463401', '249134, г. Нема, ул. Лонгиновская, 109, 398', '+7 (961) 831-03-10', '', '', '');

-- --------------------------------------------------------

--
-- Структура таблицы `receiptorder`
--

CREATE TABLE `receiptorder` (
  `PK_ReceiptOrder` int(11) NOT NULL,
  `ReceiptOrderNumber` varchar(50) DEFAULT NULL,
  `DeliveryDate` date DEFAULT NULL,
  `PK_Warehouse` int(11) DEFAULT NULL,
  `PK_Provider` int(11) DEFAULT NULL,
  `PK_Contract` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Дамп данных таблицы `receiptorder`
--

INSERT INTO `receiptorder` (`PK_ReceiptOrder`, `ReceiptOrderNumber`, `DeliveryDate`, `PK_Warehouse`, `PK_Provider`, `PK_Contract`) VALUES
(1, '000001', '2021-03-02', 2, 3, 3),
(2, '000002', '2021-03-01', 1, 2, 2),
(3, '000003', '2021-04-08', 1, 3, 1);

-- --------------------------------------------------------

--
-- Структура таблицы `receiptorderline`
--

CREATE TABLE `receiptorderline` (
  `PK_ReceiptOrderLine` int(11) NOT NULL,
  `AcceptedAmount` float DEFAULT NULL,
  `DocumentAmount` float DEFAULT NULL,
  `PK_ReceiptOrder` int(11) DEFAULT NULL,
  `PK_Resource` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Дамп данных таблицы `receiptorderline`
--

INSERT INTO `receiptorderline` (`PK_ReceiptOrderLine`, `AcceptedAmount`, `DocumentAmount`, `PK_ReceiptOrder`, `PK_Resource`) VALUES
(1, 1000, 1000, 1, 2),
(2, 1200, 1200, 1, 1);

-- --------------------------------------------------------

--
-- Структура таблицы `resource`
--

CREATE TABLE `resource` (
  `PK_Resource` int(11) NOT NULL,
  `Name` varchar(100) DEFAULT NULL,
  `Cipher` varchar(50) DEFAULT NULL,
  `PK_Unit` int(11) DEFAULT NULL,
  `PK_ResourceType` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Дамп данных таблицы `resource`
--

INSERT INTO `resource` (`PK_Resource`, `Name`, `Cipher`, `PK_Unit`, `PK_ResourceType`) VALUES
(1, 'Плита древесно-стружечная', '16.21.13.000', 6, 1),
(2, 'Плита древесно-волокнистая', '16.21.14.000', 6, 1),
(3, 'Мебельная направляющая', '25.72.14.130', 2, 1),
(4, 'Обивочная ткань', '13.20.41.110', 4, 1),
(5, 'Клей-расплав', '20.52.10.110', 5, 1),
(6, 'Винт самонарезающийся', '25.94.11.110', 2, 1),
(7, 'Форматно-раскроечный станок мод. FL-3200F', '28.49.12.119', 2, 2),
(8, 'Автомотический кромкооблицовочный станок FILATO Optima 264', '28.49.12.119', 2, 2);

-- --------------------------------------------------------

--
-- Структура таблицы `resourcetype`
--

CREATE TABLE `resourcetype` (
  `PK_ResourceType` int(11) NOT NULL,
  `Name` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Дамп данных таблицы `resourcetype`
--

INSERT INTO `resourcetype` (`PK_ResourceType`, `Name`) VALUES
(1, 'Материал'),
(2, 'Оборудование');

-- --------------------------------------------------------

--
-- Структура таблицы `unit`
--

CREATE TABLE `unit` (
  `PK_Unit` int(11) NOT NULL,
  `Name` varchar(100) DEFAULT NULL,
  `Cipher` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Дамп данных таблицы `unit`
--

INSERT INTO `unit` (`PK_Unit`, `Name`, `Cipher`) VALUES
(1, 'Кг', '134'),
(2, 'Шт', '796'),
(3, 'Г', '163'),
(4, 'М', '006'),
(5, 'М3', '113'),
(6, 'М2', '055');

-- --------------------------------------------------------

--
-- Структура таблицы `user`
--

CREATE TABLE `user` (
  `PK_User` int(11) NOT NULL,
  `Username` varchar(200) NOT NULL,
  `Password` varchar(200) NOT NULL,
  `Role` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Дамп данных таблицы `user`
--

INSERT INTO `user` (`PK_User`, `Username`, `Password`, `Role`) VALUES
(2, 'contract', '$2y$12$Uyt7YDqEk4TyecJsBTj5I.fBTeXT2a5Hiiu1Id20G.e8buy6SLmXq', 1),
(3, 'accounting', '$2y$12$ctaU.T.tUDMmCmMQvAzvl.FzicqBmiTH6a0tHSJJ91d6uhDkF4URC', 2),
(4, 'admin', '$2y$12$HnUSrPNLTd.OJGEIvoDyPeVPcg3vZxXGTH92BpC/fecVZAGydnfDS', 0);

-- --------------------------------------------------------

--
-- Структура таблицы `warehouse`
--

CREATE TABLE `warehouse` (
  `PK_Warehouse` int(11) NOT NULL,
  `Name` varchar(100) DEFAULT NULL,
  `Cipher` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Дамп данных таблицы `warehouse`
--

INSERT INTO `warehouse` (`PK_Warehouse`, `Name`, `Cipher`) VALUES
(1, 'Склад оборудования', '007'),
(2, 'Склад материалов', '002');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `contract`
--
ALTER TABLE `contract`
  ADD PRIMARY KEY (`PK_Contract`),
  ADD KEY `IX_Relationship41` (`PK_OrganizationDescription`),
  ADD KEY `Relationship40` (`PK_Provider`);

--
-- Индексы таблицы `contractline`
--
ALTER TABLE `contractline`
  ADD PRIMARY KEY (`PK_ContractLine`),
  ADD KEY `IX_Relationship11` (`PK_Resource`),
  ADD KEY `IX_Relationship13` (`PK_Contract`);

--
-- Индексы таблицы `organizationdescription`
--
ALTER TABLE `organizationdescription`
  ADD PRIMARY KEY (`PK_OrganizationDescription`);

--
-- Индексы таблицы `provider`
--
ALTER TABLE `provider`
  ADD PRIMARY KEY (`PK_Provider`);

--
-- Индексы таблицы `receiptorder`
--
ALTER TABLE `receiptorder`
  ADD PRIMARY KEY (`PK_ReceiptOrder`),
  ADD KEY `IX_Relationship30` (`PK_Warehouse`),
  ADD KEY `IX_Relationship31` (`PK_Provider`),
  ADD KEY `IX_Relationship32` (`PK_Contract`);

--
-- Индексы таблицы `receiptorderline`
--
ALTER TABLE `receiptorderline`
  ADD PRIMARY KEY (`PK_ReceiptOrderLine`),
  ADD KEY `IX_Relationship33` (`PK_ReceiptOrder`),
  ADD KEY `IX_Relationship34` (`PK_Resource`);

--
-- Индексы таблицы `resource`
--
ALTER TABLE `resource`
  ADD PRIMARY KEY (`PK_Resource`),
  ADD KEY `IX_Relationship28` (`PK_Unit`),
  ADD KEY `IX_Relationship36` (`PK_ResourceType`);

--
-- Индексы таблицы `resourcetype`
--
ALTER TABLE `resourcetype`
  ADD PRIMARY KEY (`PK_ResourceType`);

--
-- Индексы таблицы `unit`
--
ALTER TABLE `unit`
  ADD PRIMARY KEY (`PK_Unit`);

--
-- Индексы таблицы `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`PK_User`),
  ADD UNIQUE KEY `Username` (`Username`);

--
-- Индексы таблицы `warehouse`
--
ALTER TABLE `warehouse`
  ADD PRIMARY KEY (`PK_Warehouse`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `contract`
--
ALTER TABLE `contract`
  MODIFY `PK_Contract` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT для таблицы `contractline`
--
ALTER TABLE `contractline`
  MODIFY `PK_ContractLine` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT для таблицы `organizationdescription`
--
ALTER TABLE `organizationdescription`
  MODIFY `PK_OrganizationDescription` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT для таблицы `provider`
--
ALTER TABLE `provider`
  MODIFY `PK_Provider` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT для таблицы `receiptorder`
--
ALTER TABLE `receiptorder`
  MODIFY `PK_ReceiptOrder` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT для таблицы `receiptorderline`
--
ALTER TABLE `receiptorderline`
  MODIFY `PK_ReceiptOrderLine` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT для таблицы `resource`
--
ALTER TABLE `resource`
  MODIFY `PK_Resource` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT для таблицы `resourcetype`
--
ALTER TABLE `resourcetype`
  MODIFY `PK_ResourceType` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT для таблицы `unit`
--
ALTER TABLE `unit`
  MODIFY `PK_Unit` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT для таблицы `user`
--
ALTER TABLE `user`
  MODIFY `PK_User` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT для таблицы `warehouse`
--
ALTER TABLE `warehouse`
  MODIFY `PK_Warehouse` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `contract`
--
ALTER TABLE `contract`
  ADD CONSTRAINT `Relationship40` FOREIGN KEY (`PK_Provider`) REFERENCES `provider` (`PK_Provider`) ON DELETE SET NULL ON UPDATE SET NULL,
  ADD CONSTRAINT `Relationship41` FOREIGN KEY (`PK_OrganizationDescription`) REFERENCES `organizationdescription` (`PK_OrganizationDescription`) ON DELETE SET NULL ON UPDATE SET NULL;

--
-- Ограничения внешнего ключа таблицы `contractline`
--
ALTER TABLE `contractline`
  ADD CONSTRAINT `Relationship11` FOREIGN KEY (`PK_Resource`) REFERENCES `resource` (`PK_Resource`),
  ADD CONSTRAINT `Relationship13` FOREIGN KEY (`PK_Contract`) REFERENCES `contract` (`PK_Contract`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ограничения внешнего ключа таблицы `receiptorder`
--
ALTER TABLE `receiptorder`
  ADD CONSTRAINT `Relationship30` FOREIGN KEY (`PK_Warehouse`) REFERENCES `warehouse` (`PK_Warehouse`),
  ADD CONSTRAINT `Relationship31` FOREIGN KEY (`PK_Provider`) REFERENCES `provider` (`PK_Provider`),
  ADD CONSTRAINT `Relationship32` FOREIGN KEY (`PK_Contract`) REFERENCES `contract` (`PK_Contract`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ограничения внешнего ключа таблицы `receiptorderline`
--
ALTER TABLE `receiptorderline`
  ADD CONSTRAINT `Relationship33` FOREIGN KEY (`PK_ReceiptOrder`) REFERENCES `receiptorder` (`PK_ReceiptOrder`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `Relationship34` FOREIGN KEY (`PK_Resource`) REFERENCES `resource` (`PK_Resource`);

--
-- Ограничения внешнего ключа таблицы `resource`
--
ALTER TABLE `resource`
  ADD CONSTRAINT `Relationship28` FOREIGN KEY (`PK_Unit`) REFERENCES `unit` (`PK_Unit`),
  ADD CONSTRAINT `Relationship36` FOREIGN KEY (`PK_ResourceType`) REFERENCES `resourcetype` (`PK_ResourceType`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
