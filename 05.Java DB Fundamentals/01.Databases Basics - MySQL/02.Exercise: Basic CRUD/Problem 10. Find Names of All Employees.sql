SELECT em.`first_name`, em.`last_name`
FROM `employees` as em
WHERE em.`manager_id` IS NULL