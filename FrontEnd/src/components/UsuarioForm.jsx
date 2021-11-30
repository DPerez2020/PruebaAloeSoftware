import axios from "axios";
import React, { useState, useEffect } from "react";

function UsuarioForm({ guardarUsuario, usuario, handleChangeForm }) {
  const [departamento, setDepartamento] = useState([]);
  const [supervisores, setSupervisor] = useState([]);
  useEffect(() => {
    axios
      .get("https://localhost:44386/api/Departamento")
      .then((data) => {
        setDepartamento(data.data);
      })
      .catch((err) => {
        console.log(err);
      });
  }, []);
  useEffect(() => {
    axios
      .get("https://localhost:44386/api/Usuario")
      .then((data) => {
        setSupervisor(data.data);
      })
      .catch((err) => {
        console.log(err);
      });
  }, []);
  return (
    <div>
      <h2>Formulario De usuarios</h2>
      <form onSubmit={guardarUsuario}>
        <div className="row">
          <div className="col-md-6 mb-3">
            <div className="form-group">
              <label>Nombres</label>
              <input
                className="form-control"
                value={usuario.nombres}
                onChange={handleChangeForm}
                name="nombres"
                type="text"
              ></input>
            </div>
          </div>
          <div className="col-md-6 mb-3">
            <div className="form-group">
              <label>Apellidos</label>
              <input
                className="form-control"
                value={usuario.apellidos}
                onChange={handleChangeForm}
                name="apellidos"
                type="text"
              ></input>
            </div>
          </div>
        </div>
        <div className="row">
          <div className="col-md-6 mb-3">
            <div className="form-group">
              <label>Cedula</label>
              <input
                className="form-control"
                value={usuario.cedula}
                onChange={handleChangeForm}
                name="cedula"
                type="text"
              ></input>
            </div>
          </div>
          <div className="col-md-6 mb-3">
            <div className="form-group">
              <label>Cargo</label>
              <input
                className="form-control"
                value={usuario.cargo}
                onChange={handleChangeForm}
                name="cargo"
                type="text"
              ></input>
            </div>
          </div>
        </div>
        <div className="row">
          <div className="col-md-6 mb-3">
            <div className="form-group">
              <label>Fecha de Nacimiento</label>
              <input
                className="form-control"
                value={usuario.fechaNacimiento}
                name="fechaNacimiento"
                onChange={handleChangeForm}
                type="date"
              ></input>
            </div>
          </div>
          <div className="col-md-6 mb-3">
            <div className="form-group">
              <label>Genero</label>
              <select
                value={usuario.genero}
                className="form-control"
                name="genero"
                onChange={handleChangeForm}
              >
                <option value="M">Masculino</option>
                <option value="F">Femenino</option>
              </select>
            </div>
          </div>
        </div>
        <div className="form-group">
          <label>Departamento</label>
          <select
            className="form-control"
            name="departamento"
            value={usuario.departamento}
            onChange={handleChangeForm}
          >
            <option value="">Ninguno</option>
            {departamento.map((d) => {
              return (
                <option key={d.id} value={d.id}>
                  {d.nombre}
                </option>
              );
            })}
          </select>
        </div>
        <div className="form-group">
          <label>Supervisor</label>
          <select
            className="form-control"
            name="supervisor"
            value={usuario.supervisor}
            onChange={handleChangeForm}
          >
            <option value="">Ninguno</option>
            {supervisores.map((d) => {
              return (
                <option key={d.id} value={d.id}>
                  {d.nombres + d.apellidos}
                </option>
              );
            })}
          </select>
        </div>
        <input
          type="submit"
          value="Guardar"
          className="btn btn-success"
        ></input>
      </form>
    </div>
  );
}

export default UsuarioForm;
