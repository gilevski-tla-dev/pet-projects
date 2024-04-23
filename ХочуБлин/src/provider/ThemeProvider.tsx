import { createContext, useState, useEffect, FC, ReactNode } from 'react'

type ITheme = string
export interface IThemeContext {
    theme: ITheme
    setTheme: React.Dispatch<React.SetStateAction<ITheme>>
}

export const themes = {
    dark: 'dark',
    light: 'light',
}

const getTheme = () => {
    const theme = `${window?.localStorage?.getItem('theme')}`
    if (Object.values(themes).includes(theme)) return theme

    const userMedia = window.matchMedia('(prefers-color-scheme: light)')
    if (userMedia.matches) return themes.light

    return themes.dark
}

const ThemeContext = createContext<IThemeContext | undefined>(undefined)
const ThemeProvider: FC<{ children: ReactNode }> = ({ children }) => {
    const [theme, setTheme] = useState(getTheme)

    useEffect(() => {
        document.documentElement.dataset.theme = theme
        localStorage.setItem('theme', theme)
    }, [theme])

    return <ThemeContext.Provider value={{ theme, setTheme }}>{children}</ThemeContext.Provider>
}

export { ThemeContext, ThemeProvider }
