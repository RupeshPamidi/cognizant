-- Exercise 04: Peak Session Hours

SELECT event_id,
			 COUNT(*) AS sessions_between_10_12
FROM Sessions
WHERE TIME(start_time) >= '10:00:00'
	AND TIME(start_time) < '12:00:00'
GROUP BY event_id;

