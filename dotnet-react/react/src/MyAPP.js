
// import React, { Component } from 'react'


// export default class MyAPP extends Component {
//     constructor(props) {
//         super(props);
//         this.state = {
//             Player: []
//         };
//     }
//     componentDidMount() {
//         fetch("http://localhost:5007/player")
//             .then(res => res.json())
//             .then(
//                 (result) => {
//                     this.setState({
//                         Player: result
//                     });
//                 }
//             );
//     }
//     render() {
//         return (
//             <div>
//                 <h2>Player Data...</h2>
//                 <table>
//                     <thead>
//                         <tr>
//                             <th>Id</th>
//                             <th>Name</th>
//                         </tr>
//                         {this.state.Player.map(emp => (
//                             <tr>
//                                 <td>{emp.Pid}</td>
//                                 <td>{emp.Name}</td>
//                             </tr>
//                         ))}
//                     </thead>
//                 </table>
//             </div>
//         )
//     }
// }




import React from 'react';
import axios from 'axios';

export default class MyAPP extends React.Component {
  constructor() {
    super();
    this.state = {
      arr: []
    };
  }

  componentDidMount() {
   axios.get('http://localhost:5007/player')     
      .then(response => {
        console.log(response.data);
        this.setState({ arr: response.data });
      })
      .catch(error => {
        console.log(error);
      });



  }

  render() {
    return (
      <div>
        <style>
          
        </style>
        <h2>Player Data...</h2>
        <table borderCollapse="collapse" width="100%" border="2px" textAlign="center">
          <thead>
            <tr>
              <th>ID</th>
              <th>Name</th>
              <th>Skills</th>
            </tr>
          </thead>
          <tbody>
            {this.state.players.map((player) => (
              <tr key={player.pid}>
                <td>{player.pid}</td>
                <td>{player.pname}</td>
                <td>{player.skills}</td>
              </tr>
            ))}
          </tbody>
        </table>
      </div>
    );
  }
}

