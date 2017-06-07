SELECT concat(emp.`first_name`, '.', emp.`last_name`, '@', 'softuni.bg' ) as `full_email_address`
FROM `employees` as emp;