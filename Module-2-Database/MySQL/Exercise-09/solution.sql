-- Exercise 09: Organizer Event Summary

SELECT u.user_id AS organizer_id, u.full_name AS organizer_name,
	   COUNT(e.event_id) AS total_events,
	   SUM(e.status = 'upcoming') AS upcoming_count,
	   SUM(e.status = 'completed') AS completed_count,
	   SUM(e.status = 'cancelled') AS cancelled_count
FROM Events e
JOIN Users u ON u.user_id = e.organizer_id
GROUP BY u.user_id, u.full_name
ORDER BY total_events DESC;

