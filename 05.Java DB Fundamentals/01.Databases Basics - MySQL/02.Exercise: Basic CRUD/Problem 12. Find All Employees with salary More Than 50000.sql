SELECT em.`first_name`, em.`last_name`, em.`salary`
FROM `employees` as em
WHERE em.`salary` > '50000'
ORDER BY em.`salary` DESC