
import './App.css';
import UsuarioForm from './components/UsuarioForm';
import UsuarioList from './components/UsuarioList.jsx'
import React, { useEffect, useState } from 'react'
import axios from 'axios';

function App() {
  const [usuarios,setUsuarios]=useState([]);
  const getUsuarios=()=>{
    axios.get("https://localhost:44386/api/Usuario").then(data=>{
      console.log(data.data);
      setUsuarios(data.data)
    })
    .catch(err=>{
      console.log(err);
    })
  }
  useEffect(()=>{
    getUsuarios();
  },[])
  const [usuario,setUsuario]=useState({
    nombres:'',
    apellidos:'',
    genero:'',
    cedula:'',
    cargo:'',
    supervisor:undefined,
    fechaNacimiento:'',
    departamento:undefined
  })
  const handleChangeForm = (e)=>{
    setUsuario(
      prev => ({
        ...prev,
        [e.target.name]: e.target.value
      })
      )
    }
    const guardarUsuario=(e)=>{
      e.preventDefault();
      console.log(usuario);
      axios.post("https://localhost:44386/api/Usuario",usuario).then(result=>{
        getUsuarios();
      })
      .catch(err=>{
        console.log(err);
      })
    }
    return (
    <div className="App"> 
      <div className="row">
        <div className="col">
          <UsuarioForm guardarUsuario={guardarUsuario} handleChangeForm={handleChangeForm} usuario={usuario}></UsuarioForm> 
        </div>
        <div className="col">
          <UsuarioList usuarios={usuarios}></UsuarioList>
        </div>
      </div>
    </div>
  );
}

export default App;
