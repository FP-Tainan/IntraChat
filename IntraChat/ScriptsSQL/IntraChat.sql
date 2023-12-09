CREATE DATABASE IntraChat;

CREATE TABLE tbl_Usuario (
    id SERIAL PRIMARY KEY,
    usuario VARCHAR(255),
    nome VARCHAR(255),
    senha VARCHAR(10),
    UNIQUE (usuario)
);

CREATE TABLE tbl_Chat (
    id SERIAL PRIMARY KEY,
    Interlocutor01 INTEGER REFERENCES tbl_Usuario(id),
    Interlocutor02 INTEGER REFERENCES tbl_Usuario(id)
);

CREATE TABLE tbl_HistoricoAnexos (
    Chat_id INTEGER,
    NomeArquivo VARCHAR(255),
    CaminhoArquivo VARCHAR(255),
    Usuario_id INTEGER REFERENCES tbl_Usuario(id),
    HorarioEnvio DATE,
    PRIMARY KEY (Chat_id, Usuario_id)
);

CREATE TABLE tbl_HistoricoTexto (
    Chat_id INTEGER,
    Mensagem VARCHAR(255),
    Usuario_id INTEGER REFERENCES tbl_Usuario(id),
    HorarioEnvio DATE,
    PRIMARY KEY (Chat_id, Usuario_id)
);