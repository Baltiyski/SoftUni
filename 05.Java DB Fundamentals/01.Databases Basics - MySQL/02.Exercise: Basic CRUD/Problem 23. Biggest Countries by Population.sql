SELECT cc.`country_name`, cc.`population`
FROM `countries` as cc
WHERE cc.`continent_code` = 'EU'
ORDER BY cc.`population` DESC, cc.`country_name`
LIMIT 30;