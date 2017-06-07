SELECT dd.`first_name`, dd.`last_name` ,dd.`hire_date`
FROM `employees` as dd
ORDER BY dd.`hire_date` DESC
LIMIT 7