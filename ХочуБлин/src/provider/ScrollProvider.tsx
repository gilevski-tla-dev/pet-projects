import { createContext, useState, FC, ReactNode, useEffect } from 'react'

type IScroll = number
export interface IScrollContext {
    scroll: IScroll
    setScroll: React.Dispatch<React.SetStateAction<IScroll>>
}

const ScrollContext = createContext<IScrollContext | undefined>(undefined)
const ScrollProvider: FC<{ children: ReactNode }> = ({ children }) => {
    const [scroll, setScroll] = useState(0)
    useEffect(() => {
        const handleScroll = () => setScroll(window.scrollY)
        window.addEventListener('scroll', handleScroll)
        window.scrollTo(0, 1)
        return () => {
            window.removeEventListener('scroll', handleScroll)
        }
    }, [])

    return <ScrollContext.Provider value={{ scroll, setScroll }}>{children}</ScrollContext.Provider>
}

export { ScrollContext, ScrollProvider }
