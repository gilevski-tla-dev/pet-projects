import { useEffect, useContext, useState, RefObject } from 'react'
import { IScrollContext, ScrollContext } from 'src/provider/ScrollProvider'

const useViewOnScroll = (ref: RefObject<HTMLElement>) => {
    const { scroll } = useContext(ScrollContext) as IScrollContext
    const [view, setView] = useState(false)

    const current = ref.current!
    useEffect(() => {
        if (!current) return

        const window_center = window.innerHeight / 1.2
        const scroll_offset = current.getBoundingClientRect().top
        // if (delay == 1) console.log(window_center.toFixed(0), scroll_offset.toFixed(0))
        if (window_center > scroll_offset) setView(true)
        else if (window.innerHeight < scroll_offset) setView(false)
    }, [scroll])
    return [view, setView]

    return [view, setView]
}
export default useViewOnScroll
