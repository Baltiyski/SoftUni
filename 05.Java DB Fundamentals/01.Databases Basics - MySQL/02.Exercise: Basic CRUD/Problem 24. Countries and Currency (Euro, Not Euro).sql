SELECT cc.`country_name`, cc.`country_code`,
	CASE
		WHEN cc.`currency_code` = 'EUR' THEN 'Euro' 
        ELSE 'Not Euro'
	END as 'currency'
FROM `countries` as cc
ORDER BY cc.`country_name` ASC