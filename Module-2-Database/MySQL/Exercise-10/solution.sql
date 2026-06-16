-- Exercise 10: Feedback Gap

SELECT DISTINCT e.event_id, e.title
FROM Events e
JOIN Registrations r ON r.event_id = e.event_id
LEFT JOIN Feedback f ON f.event_id = e.event_id
WHERE f.feedback_id IS NULL;

