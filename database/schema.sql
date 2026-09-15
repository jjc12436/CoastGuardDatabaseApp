-- Proposed DEMO schema inferred from the application, not an export or migration.
-- Run only to create a NEW, empty demo database. Do not rename this to target
-- your existing database. MySQL 8.0.16+ is required for enforced CHECK constraints.
CREATE DATABASE coast_guard_assets_demo CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;
USE coast_guard_assets_demo;

CREATE TABLE station (
    station_id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    station_name VARCHAR(100) NOT NULL,
    location VARCHAR(150) NOT NULL,
    CHECK (CHAR_LENGTH(TRIM(station_name)) > 0),
    CHECK (CHAR_LENGTH(TRIM(location)) > 0)
) ENGINE=InnoDB;

CREATE TABLE asset (
    asset_id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    asset_name VARCHAR(100) NOT NULL,
    asset_type VARCHAR(30) NOT NULL,
    status VARCHAR(30) NOT NULL,
    station_id INT NULL,
    FOREIGN KEY (station_id) REFERENCES station(station_id) ON DELETE RESTRICT,
    CHECK (CHAR_LENGTH(TRIM(asset_name)) > 0),
    CHECK (asset_type IN ('Boat', 'Vehicle', 'Aircraft', 'Trailer', 'Other')),
    CHECK (status IN ('Available', 'Underway', 'Maintenance', 'Out of Service', 'Reserved'))
) ENGINE=InnoDB;

CREATE TABLE crew_member (
    crew_id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    first_name VARCHAR(50) NOT NULL,
    last_name VARCHAR(50) NOT NULL,
    rank_name VARCHAR(50) NULL,
    qualification VARCHAR(255) NULL,
    CHECK (CHAR_LENGTH(TRIM(first_name)) > 0),
    CHECK (CHAR_LENGTH(TRIM(last_name)) > 0)
) ENGINE=InnoDB;

CREATE TABLE mission (
    mission_id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    mission_type VARCHAR(50) NOT NULL,
    start_date DATE NULL,
    end_date DATE NULL,
    status VARCHAR(30) NOT NULL,
    asset_id INT NOT NULL,
    FOREIGN KEY (asset_id) REFERENCES asset(asset_id) ON DELETE RESTRICT,
    CHECK (mission_type IN ('Search and Rescue', 'Law Enforcement', 'Safety Patrol',
        'Training', 'Security', 'Environmental Response', 'Other')),
    CHECK (status IN ('Planned', 'Active', 'Completed', 'Cancelled')),
    CHECK (end_date IS NULL OR start_date IS NULL OR end_date >= start_date)
) ENGINE=InnoDB;

CREATE TABLE maintenance_record (
    maintenance_id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    asset_id INT NOT NULL,
    maintenance_type VARCHAR(100) NOT NULL,
    service_date DATE NULL,
    next_due_date DATE NULL,
    maintenance_status VARCHAR(30) NOT NULL,
    notes TEXT NULL,
    FOREIGN KEY (asset_id) REFERENCES asset(asset_id) ON DELETE RESTRICT,
    INDEX ix_maintenance_due (maintenance_status, next_due_date),
    CHECK (CHAR_LENGTH(TRIM(maintenance_type)) > 0),
    CHECK (maintenance_status IN ('Scheduled', 'In Progress', 'Completed', 'Cancelled', 'Overdue')),
    CHECK (service_date IS NULL OR next_due_date IS NULL OR next_due_date >= service_date)
) ENGINE=InnoDB;

CREATE TABLE mission_crew (
    mission_id INT NOT NULL,
    crew_id INT NOT NULL,
    role_on_mission VARCHAR(100) NULL,
    PRIMARY KEY (mission_id, crew_id),
    FOREIGN KEY (mission_id) REFERENCES mission(mission_id) ON DELETE RESTRICT,
    FOREIGN KEY (crew_id) REFERENCES crew_member(crew_id) ON DELETE RESTRICT
) ENGINE=InnoDB;
