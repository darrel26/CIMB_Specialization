CREATE DATABASE kantor

USE kantor

CREATE TABLE employee (
  id INT(11) NOT NULL AUTO_INCREMENT,
  nama VARCHAR(15) NOT NULL,
  jenis_kelamin ENUM('Laki-Laki', 'Perempuan') NOT NULL,
  alamat VARCHAR(50) NOT NULL,
  PRIMARY KEY (id)
);

INSERT INTO data_diri (nama, jenis_kelamin, alamat) VALUES
('Andi', 'Laki-Laki', 'Jakarta'),
('Budi', 'Laki-Laki', 'Bandung'),
('Cici', 'Perempuan', 'Semarang'),
('Dedi', 'Laki-Laki', 'Surabaya');