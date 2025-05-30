--c##Thai
--Tao bang user
create table Users(
    UserID int GENERATED ALWAYS AS IDENTITY(START WITH 1 INCREMENT BY 1) not null,
    FullName varchar2(100),
    Gender varchar2(10),
    Email varchar(100),
    Password varchar2(250),
    primary key (userID)
);
--Tao bang Expenses Type
create table ExpensesType(
    ExTypeID int GENERATED ALWAYS AS IDENTITY(START WITH 1 INCREMENT BY 1) not null,
    NameExType varchar2(250),
    UserID int,
	isActive char(1) DEFAULT 'Y',
    primary key(ExTypeID),
    foreign key (UserID) references Users(UserID)
);
--Tao bang Expenses
create table Expenses (
    ExpensesID int GENERATED ALWAYS AS IDENTITY(START WITH 1 INCREMENT BY 1) not null,
    UserID int,
    ExTypeID int,
    Money number(12,2),
    ExDate date,
    Note varchar2(250),
    primary key(ExpensesID),
    foreign key (UserID) references Users(UserID),
    foreign key (ExTypeID) references ExpensesType(ExTypeID)
);
--tao bang IncomeType
create table IncomeType(
    InTypeID int GENERATED ALWAYS AS IDENTITY(START WITH 1 INCREMENT BY 1) not null,
    NameInType varchar2(250),
    UserID int,
	isActive char(1) DEFAULT 'Y',
    primary key (InTypeID),
    foreign key (UserID) references Users(UserID)
);
--tao bang Income
create table Income(
    IncomeID int GENERATED ALWAYS AS IDENTITY(START WITH 1 INCREMENT BY 1) not null,
    UserID int,
    InTypeID int,
    Money number(12,2),
    InDate date,
    Note varchar2(250),
    primary key(IncomeID),
    foreign key (UserID) references Users(UserID),
    foreign key (InTypeID) references IncomeType(InTypeID)
);
