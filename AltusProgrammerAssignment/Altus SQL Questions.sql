--Question 5
CREATE TABLE orders  
(	[order_id]    [bigint] NOT NULL,  
	[item_id]     [bigint] NOT NULL,  
	[customer_id] [bigint] NOT NULL,  
	[date]		  [datetime] NOT NULL,  
	[price]		  [money] NOT NULL,  
CONSTRAINT [PK_orders] PRIMARY KEY CLUSTERED ([order_id] ASC))


SELECT order_id, item_id, date, price  
FROM orders  
WHERE customer_id = @this_customer  

--Answer
CREATE TABLE orders  
(	[order_id]    [bigint] NOT NULL,  
	[item_id]     [bigint] NOT NULL,  
	[customer_id] [bigint] NOT NULL,  
	[date]		  [datetime] NOT NULL,  
	[price]		  [money] NOT NULL,  
CONSTRAINT [PK_orders] PRIMARY KEY CLUSTERED ([order_id] ASC))

CREATE NONCLUSTERED INDEX [idx_orders_date] ON [dbo].[orders]
(
	[orders] DESC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 95) ON [PRIMARY]
GO

SELECT order_id, item_id, date, price  
FROM orders nolock
WHERE customer_id = @this_customer  
order by date desc

--Adding an Index and nolock to a table will help performance, the other issue i see here is the size of the result set, to limit this you can add retrival limits to the table. 
--This would require changes to your web app to pass the row count to use. 
--ex.
--you need to set num1 and num2, so lets set them to 0 and 10, you would get the frist 10 rows
-- then when the user wants the next 10 records you can send num1 = 11 and num2 = 20

declare @num1 int,
		@num2 int

SELECT ROW_NUMBER() OVER (ORDER BY order_id) as 'rownbr', order_id, item_id, date, price 
FROM orders
WHERE rownbr BETWEEN @num1 and @num2
and customer_id = @this_customer  
order by date desc


--Question 6
declare @date1 datetime,
		@date2 datetime

Select top(25) sale_rep, Sum(value) as sumValue
where date between date1 and date2
Group by sale_rep
order by sumValue desc

--Question 7
WITH    numbered
        AS ( SELECT   col1, col2, col3, col4, row_number() OVER ( PARTITION BY col1, col2, col3, col4 ORDER BY col1, col2, col3, col4 ) AS nr
            FROM     sometable
            )
DELETE  FROM numbered
WHERE   nr > 1

--Question 8

CREATE TABLE [dbo].[TreeCategoies]
(
	[Parent] [nvarchar](50) NULL,
	[Name] [nvarchar](50) NOT NULL
) 
declare @SelectedCategory varchar(50)

SELECT           [TrunkCat].[Name] AS [Trunk]
                ,[BranchCat].[Name] AS [Branch]

FROM            [TreeCategoies] AS [TrunkCat]
LEFT OUTER JOIN [TreeCategoies] AS [BranchCat] 
		     ON [BranchCat].[Parent] = [TrunkCat].[Name]

WHERE           [TrunkCat].[Name] = @SelectedCategory
ORDER BY        [Trunk],  [Branch]

Drop Table  [dbo].[TreeCategoies]           

GO

--Question 9

CREATE TABLE [dbo].[TreeCategoies]
(
	[Parent] [nvarchar](50) NULL,
	[Name] [nvarchar](50) NOT NULL
) 
declare @SelectedCategory varchar(50)

SELECT           [TrunkCat].[Name] AS [Trunk]
                ,[BranchCat].[Name] AS [Branch]
				,[SubBranchCat].[Name] AS [SubBranch]

FROM            [TreeCategoies] AS [TrunkCat]
LEFT OUTER JOIN [TreeCategoies] AS [BranchCat] 
		     ON [BranchCat].[Parent] = [TrunkCat].[Name]
LEFT OUTER JOIN [TreeCategoies] AS [SubBranchCat] 
		     ON [SubBranchCat].[Parent] = [BranchCat].[Name]

WHERE           [TrunkCat].[Name] = @SelectedCategory
ORDER BY        [Trunk],  [Branch], [SubBranch]

Drop Table  [dbo].[TreeCategoies]           

GO

