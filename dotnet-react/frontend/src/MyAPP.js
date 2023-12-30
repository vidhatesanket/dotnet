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




import React, { Component } from 'react';
import axios from 'axios';

export default class MyAPP extends Component {
  constructor(props) {
    super(props);
    this.state = {
      players: []
    };
  }

  componentDidMount() {
    axios.get('http://localhost:5007/player',{mode:'cors'})
      .then(response => {
       
        // response.set( Access-Control-Allow-Origin, localhost:5007);
        // response.AppendHeader("Access-Control-Allow-Origin", "*");
        console.log(response.data);
        this.setState({ players: response.data });
      })
      .catch(error => {
        console.log(error);
      });
  }

  render() {
    return (
      <div>
        <h2>Player Data...</h2>
        <table>
          <thead>
            <tr>
              <th>ID</th>
              <th>Name</th>
            </tr>
          </thead>
          <tbody>
            {this.state.players.map(player => (
              <tr key={player.pid}>
                <td>{player.pid}</td>
                <td>{player.pname}</td>
              </tr>
            ))}
          </tbody>
        </table>
      </div>
    );
  }
}

