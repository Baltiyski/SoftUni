SELECT em.`first_name`, em.`last_name` ,em.`job_title`
FROM `employees` as em
where em.`salary` BETWEEN '20000' AND '30000'