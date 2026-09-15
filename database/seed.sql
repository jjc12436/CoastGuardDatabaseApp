-- Fictional demo data only. Run ONCE after schema.sql in the demo database.
-- Repeating this script inserts another set; it is not a reset script.
USE coast_guard_assets_demo;
START TRANSACTION;
INSERT INTO station (station_name, location) VALUES ('Demo Station', 'Fictional Harbor');
SET @demo_station = LAST_INSERT_ID();
INSERT INTO asset (asset_name, asset_type, status, station_id)
VALUES ('Demo Boat 01', 'Boat', 'Available', @demo_station);
SET @demo_asset = LAST_INSERT_ID();
INSERT INTO crew_member (first_name, last_name, rank_name, qualification)
VALUES ('Alex', 'Morgan', 'Demo rank', 'Demo boat crew');
SET @demo_crew = LAST_INSERT_ID();
INSERT INTO mission (mission_type, start_date, end_date, status, asset_id)
VALUES ('Training', CURDATE(), NULL, 'Planned', @demo_asset);
SET @demo_mission = LAST_INSERT_ID();
INSERT INTO mission_crew (mission_id, crew_id, role_on_mission)
VALUES (@demo_mission, @demo_crew, 'Crew member');
INSERT INTO maintenance_record
    (asset_id, maintenance_type, service_date, next_due_date, maintenance_status, notes)
VALUES (@demo_asset, 'Demo inspection', NULL, CURDATE(), 'Scheduled', 'Fictional test record.');
COMMIT;
