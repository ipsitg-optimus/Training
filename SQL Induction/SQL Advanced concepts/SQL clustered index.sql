
-- Create a new table with three columns.
CREATE TABLE test
    (col1 int NOT NULL,
     col2 nchar(10) NULL,
     col3 nvarchar(50) NULL);
     
--creates a clustered index on column col1.     
CREATE CLUSTERED INDEX cluster_index
    ON test (col1); 
GO