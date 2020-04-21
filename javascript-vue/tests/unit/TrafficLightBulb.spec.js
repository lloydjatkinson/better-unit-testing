import { mount } from '@vue/test-utils';
import TrafficLightBulb from '../../src/components/TrafficLightBulb';
import { Red, Green } from '../../src/components/traffic-light-states';

describe('TrafficLightBulb.vue', () => {
    it('should display red bulb when on', () => {
        const wrapper = mount(TrafficLightBulb, {
            propsData: {
                on: true,
                colour: Red,
            },
        });

        expect(wrapper.vm.colourStyle['bg-red-on']).toBe(true);
    });

    it('should display green bulb when off', () => {
        const wrapper = mount(TrafficLightBulb, {
            propsData: {
                on: false,
                colour: Green,
            },
        });

        expect(wrapper.vm.colourStyle['bg-green-off']).toBe(true);
    });
});