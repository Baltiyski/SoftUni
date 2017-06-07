CREATE VIEW `v_employees_job_titles` AS
SELECT 
	CONCAT(e.`first_name`, ' ', IFNULL(e.`middle_name`, ''), ' ', e.`last_name`) AS 'Full Name',
	e.`job_title`
FROM `employees` AS e;
