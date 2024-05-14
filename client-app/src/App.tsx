import './App.css'
import { ThemeProvider } from "@/components/theme-provider"
import { Button } from './components/ui/button'
import { useEffect, useState } from 'react'
import axios from 'axios'
import { HeadingOne } from './components/Typography/Headers'
import { List } from './components/Typography/Text'

function App() {
  const [activities, setActivities] = useState([]);

  useEffect(() => {
    axios.get('http://localhost:5000/api/activities')
      .then(response => {
        setActivities(response.data)
      })
  })

  return (
    <ThemeProvider defaultTheme="dark" storageKey="vite-ui-theme">
      <HeadingOne>
        Reactivities
      </HeadingOne>
      <Button>Hello</Button>

      <List>
        {activities.map((activity: any)=> (
          <li key={activity.id}>
            {activity.title}
          </li>
        ))}
      </List>
    </ThemeProvider>
  )
}

export default App
