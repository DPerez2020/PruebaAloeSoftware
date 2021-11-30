import React from 'react'

const UsuarioList=({usuarios})=>{    
    return(
        <div>
            <h1>Lista de usuarios</h1>
            <table className="table">
                <thead>
                    <tr>
                        <th>Nombres</th>
                        <th>Apellidos</th>
                        <th>Cedula</th>
                        <th>Cargo</th>
                        <th>Supervisor</th>
                        <th>Departamento</th>
                        <th>Fecha Nacimiento</th>
                    </tr>
                </thead>
                <tbody>
                    {usuarios.map(u=>{
                        return(
                        <tr key={u.id} >
                            <td>{u.nombres}</td>
                            <td>{u.apellidos}</td>
                            <td>{u.cedula}</td>
                            <td>{u.cargo}</td>
                            <td>{u.supervisorInmediato?.nombres + u.supervisorInmediato?.apellidos}</td>
                            <td>{u.departamento?.nombre}</td>
                            <td>{u.fechaNacimiento}</td>
                        </tr>
                        )
                    })}
                </tbody>
            </table>
        </div>
    );
}

export default UsuarioList;