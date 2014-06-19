-- Create a new table with three columns.
CREATE TABLE test1
    (col1 int NOT NULL,
     col2 nchar(10) NULL,
     col3 nvarchar(50) NULL);
     
--creates a clustered index on column col1.     
CREATE NONCLUSTERED INDEX cluster_index
    ON test1 (col1); 
GO