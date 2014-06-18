--displays sum of columns in which a value is null.
SELECT 
 sum((CASE WHEN employee_id IS NULL THEN 1 ELSE 0 END)+
 (CASE WHEN first_name IS NULL THEN 1 ELSE 0 END)+
 (CASE WHEN last_name IS NULL THEN 1 ELSE 0 END)+
 (CASE WHEN designation_id IS NULL THEN 1 ELSE 0 END)+
 (CASE WHEN department_id IS NULL THEN 1 ELSE 0 END)+
 (CASE WHEN salary_id IS NULL THEN 1 ELSE 0 END)+
 (CASE WHEN age IS NULL THEN 1 ELSE 0 END)+
 (CASE WHEN sex IS NULL THEN 1 ELSE 0 END)+
 (CASE WHEN active IS NULL THEN 1 ELSE 0 END)+
 (CASE WHEN half_yearly_grade IS NULL THEN 1 ELSE 0 END)) AS sum_of_nulls
FROM employee